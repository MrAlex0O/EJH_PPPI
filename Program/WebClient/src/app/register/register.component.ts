import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { UserService } from '../_services/auth.service';
import { RegisterModel } from '../_models/registerModel'
import { RoleModel } from '../_models/roleModel';
import { GenericComboBoxComponent } from '../generic-combo-box/generic-combo-box.component';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  roles: RoleModel[] = [];
  @Input() selected: RoleModel;
  @ViewChild(GenericComboBoxComponent) viewChild!: GenericComboBoxComponent;
  renderFunction = (item: RoleModel) => { return `${item.name}`; }
  form: RegisterModel = {
    name: "",
    surname: "",
    email: "",
    username: "",
    password: "",
    role: ""
  };
  isSuccessful = false;
  isSignUpFailed = false;
  errorMessage = '';
  constructor(private _userService: UserService) { }
  ngOnInit(): void {
    this._userService.getRoles().subscribe(roles => this.roles.push(...roles));
  }
  importValue(role: RoleModel) {
    this.selected = role;
  }

  onSubmit(): void {
    this.form.role = this.selected.name;
    this._userService.register(this.form).subscribe({
      next: data => {
        console.log(data);
        this.isSuccessful = true;
        this.isSignUpFailed = false;
      },
      error: err => {
        this.errorMessage = err.error.message;
        this.isSignUpFailed = true;
      }
    });
  }
}
