import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { GenericComboBoxComponent } from '../generic-combo-box/generic-combo-box.component';
import { RenderFunctions } from '../_helpers/renderFunctions';
import { GroupModel } from '../_models/groupModel';
import { StudentModel } from '../_models/studentModel';
import { GroupService } from '../_services/group.service';
import { StudentService } from '../_services/student.service'

@Component({
  selector: 'app-student-manager',
  templateUrl: './student-manager.component.html',
  styleUrls: ['./student-manager.component.css']
})
export class StudentManagerComponent implements OnInit {

  @Input() selected: StudentModel;
  name: string = "";
  midname: string = "";
  surname: string = "";
  email: string = "";
  address: string = "";
  phoneNumber: string = "";
  groupId: string = "";
  groups: GroupModel[] = [];
  students: StudentModel[] = [];
  @ViewChild('groupSelector') groupViewChild!: GenericComboBoxComponent;
  studentRenderFunction = RenderFunctions.studentRenderFunction;
  groupRenderFunction = RenderFunctions.groupRenderFunction;
  loading: boolean = false;

  constructor(private _studentService: StudentService, private _groupService: GroupService) { }
  ngOnInit(): void {
    this._groupService.getAll().subscribe(groups => this.groups.push(...groups));
    this._studentService.getAll().subscribe(students => this.students.push(...students));
    this.name = this.selected.name;
    this.surname = this.selected.surname;
    this.midname = this.selected.midname;
    this.email = this.selected.email;
    this.address = this.selected.address;
    this.phoneNumber = this.selected.phoneNumber;
  }
  importValue(student: StudentModel) {
    this.selected = student;
    this.name = student.name;
    this.surname = student.surname;
    this.midname = student.midname;
    this.email = student.email;
    this.address = student.address;
    this.phoneNumber = student.phoneNumber;
    this.groupViewChild.showById(student.groupId);
    console.log(student);
  }

  importGroup(group: GroupModel) {
    this.groupId = group.id;
  }
  update() {
    this.loading = true;
    let student: StudentModel = {
      name: this.name, id: this.selected.id, midname: this.midname,
      surname: this.surname,
      address: this.address,
      email: this.email,
      phoneNumber: this.phoneNumber,
      groupId: this.groupId,
      groupName: ""
    }
    this._studentService.Update(student).subscribe(() => this.loading = false);
  }
  add() {
    let student: StudentModel = {
      name: this.name, id: "", midname: this.midname,
      surname: this.surname,
      address: this.address,
      email: this.email,
      phoneNumber: this.phoneNumber,
      groupId: this.groupId,
      groupName: ""
    }
    this.loading = true;
    this._studentService.Add(student).subscribe(() => this.loading = false);
  }
  delete() {
    this.loading = true;
    this._studentService.Delete(this.selected).subscribe(() => this.loading = false);
  }

}
