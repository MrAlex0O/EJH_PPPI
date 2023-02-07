import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnChanges, OnInit, Output, TemplateRef, ViewChild, ViewContainerRef } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, retry, startWith } from 'rxjs/operators';
import { BaseModel } from '../_models/BaseModel';

@Component({
  selector: 'app-generic-combo-box',
  templateUrl: './generic-combo-box.component.html',
  styleUrls: ['./generic-combo-box.component.css']
})
export class GenericComboBoxComponent implements OnInit, OnChanges {
  @Input() public models: BaseModel[] = [];
  @Input() public selectedModel: BaseModel;
  @Output() myEvent = new EventEmitter<any>();
  @Input() loading: boolean = false;
  @Input() placeholder: string = "";
  showValue: string = '';
  public modelControl = new FormControl();

  myControl = new FormControl();

  filteredOptions: BaseModel[] = [];
  @Input() viewPattern = (item: any) => {
    return item.toString();
  };

  constructor() {}

  ngOnInit(): void {
this.myControl.valueChanges.pipe(
      startWith(''),
      map(value => this._filter(value)),
).subscribe(opts => {
  this.filteredOptions = opts;
   });
}
  ngOnChanges() {

    console.log(this.models);
    
    if (this.loading == false) {
    }
  }

  exportValue(a: BaseModel) {
    this.selectedModel = a;
    this.showValue = this.viewPattern(a);
    this.myEvent.emit(<any>this.selectedModel);
  }

  public showById(id: string) {

    this.selectedModel = <BaseModel>this.models.find(g => g.id == id);
    this.showValue = this.viewPattern(this.selectedModel);
  }



  private _filter(value: BaseModel | string): BaseModel[] {
    if (value == '') return this.models;

    let filterValue = '';
    if (typeof (value) === 'string') {

      filterValue = value.toLowerCase();
    }
    else {

    filterValue = this.viewPattern(value).toLowerCase();
    }
    return this.models.filter(option => this.viewPattern(option).toLowerCase().includes(filterValue));
  }

  clear() {
    this.showValue = '';
  }


}

