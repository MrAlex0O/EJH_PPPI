import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { GenericComboBoxComponent } from '../generic-combo-box/generic-combo-box.component';
import { RenderFunctions } from '../_helpers/renderFunctions';
import { GroupModel } from '../_models/groupModel';
import { GroupService } from '../_services/group.service'

@Component({
  selector: 'app-group-manager',
  templateUrl: './group-manager.component.html',
  styleUrls: ['./group-manager.component.css']
})
export class GroupManagerComponent implements OnInit {

  @Input() selected: GroupModel;
  groups: GroupModel[] = [];
  name: string = "";
  @ViewChild(GenericComboBoxComponent) viewChild!: GenericComboBoxComponent;
  groupRenderFunction = RenderFunctions.groupRenderFunction;
  loading: boolean = false;

  constructor(private _groupService: GroupService) { }

  ngOnInit(): void {
    this._groupService.getAll().subscribe(groups => this.groups.push(...groups));
  }

  importValue(group: GroupModel) {
    this.selected = group;
    this.name = group.name;
    console.log(group);
  }
  update() {
    let group: GroupModel = { name: this.name, id: this.selected.id }
    this.loading = true;
    this._groupService.Update(group).subscribe(() => this.loading = false);
  }
  add() {
    let group: GroupModel = { name: this.name, id: "" }
    this.loading = true;
    this._groupService.Add(group).subscribe(() => this.loading = false);
  }
  delete() {
    this.loading = true;
    this._groupService.Delete(this.selected).subscribe(() => this.loading = false);
  }

}
