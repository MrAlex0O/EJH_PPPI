import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { DisciplineModel } from '../_models/disciplineModel';
import { GroupModel } from '../_models/groupModel';
import { TeacherModel } from '../_models/teacherModel';
import { DisciplineService } from '../_services/discipline.service';
import { TeacherService } from '../_services/teacher.service';
import { GroupService } from '../_services/group.service';
import { GenericComboBoxComponent } from '../generic-combo-box/generic-combo-box.component';
import { RenderFunctions } from '../_helpers/renderFunctions';

@Component({
  selector: 'app-discipline-manager',
  templateUrl: './discipline-manager.component.html',
  styleUrls: ['./discipline-manager.component.css']
})
export class DisciplineManagerComponent implements OnInit {

  

  @Input() selected: DisciplineModel;
  id: string = "";
  name: string = "";
  lectorId: string = "";
  lectorFullName: string = "";
  groupId: string = "";
  groupName: string = "";
  semester: number = 0;
  assistantsIds: string[] = [];
  assistantsFullNames: string[] = [];
  @ViewChild('lectorSelector') lectorViewChild!: GenericComboBoxComponent;
  @ViewChild('assistantSelector') assistantViewChild!: GenericComboBoxComponent;
  @ViewChild('groupSelector') groupViewChild!: GenericComboBoxComponent;
  teacherRenderFunction = RenderFunctions.teacherRenderFunction;
  disciplineRenderFunction = RenderFunctions.disciplineRenderFunction;
  groupRenderFunction = RenderFunctions.groupRenderFunction;
  groups: GroupModel[] = [];
  teachers: TeacherModel[] = [];
  disciplines: DisciplineModel[] = [];
  loading: boolean = false;
  constructor(private _disciplineService: DisciplineService, private _teacherService: TeacherService, private _groupService: GroupService) { }

  ngOnInit(): void {
    this._teacherService.getAll().subscribe(teachers => this.teachers.push(...teachers));
    this._disciplineService.getAll().subscribe(disciplines => this.disciplines.push(...disciplines));
    this._groupService.getAll().subscribe(groups => this.groups.push(...groups));
  }

  importDiscipline(discipline: DisciplineModel) {
    this.selected = discipline;
    this.id = discipline.id;
    this.name = discipline.name;
    this.lectorId = discipline.lectorId;
    this.lectorFullName = discipline.lectorFullName;

    this.lectorViewChild.showById(this.lectorId);

    this.groupId = discipline.groupId;
    this.groupName = discipline.groupName;

    this.groupViewChild.showById(this.groupId);

    this.semester = discipline.semester;
    this.assistantsIds = discipline.assistantsIds;
    this.assistantsFullNames = discipline.assistantsFullNames;
    console.log(discipline);
  }
  importLector(teacher: TeacherModel) {
    this.lectorId = teacher.id;
  }
  importGroup(group: GroupModel) {
    this.groupId = group.id;
  }

  deleteAssistant(index: number) {
    this.assistantsFullNames.splice(index, 1);
    this.assistantsIds.splice(index, 1);
  }

  addAssistant() {
    const id = this.assistantViewChild.selectedModel.id;
    const teacher = <TeacherModel>this.teachers.find(i => i.id == id);
    const fullname = teacher.surname + " " + teacher.name + " " + teacher.midname;
    this.assistantsFullNames.push(fullname);
    this.assistantsIds.push(this.assistantViewChild.selectedModel.id);
  }

  addDiscipline() {
    let discipline: DisciplineModel = {
      name: this.name,
      id: "",
      lectorId: this.lectorViewChild.selectedModel.id,
      lectorFullName: "",
      groupId: this.groupViewChild.selectedModel.id,
      groupName: "",
      semester: this.semester,
      assistantsIds: this.assistantsIds,
        assistantsFullNames: []
    }
    this.loading = true;
    this._disciplineService.Add(discipline).subscribe(() => this.loading = false);

  }
  deleteDiscipline() {
    this.loading = true;
    this._disciplineService.Delete(this.selected).subscribe(() => this.loading = false);
  }
  
  updateDiscipline() {
    let discipline: DisciplineModel = {
      name: this.name,
      id: this.id,
      lectorId: this.lectorViewChild.selectedModel.id,
      lectorFullName: "",
      groupId: this.groupViewChild.selectedModel.id,
      groupName: "",
      semester: this.semester,
      assistantsIds: this.assistantsIds,
        assistantsFullNames: []
    }
    this.loading = true;
    this._disciplineService.Update(discipline).subscribe(() => this.loading = false);
  }
}

