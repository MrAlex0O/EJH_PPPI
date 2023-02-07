import { BaseModel } from "./BaseModel";

export interface TeacherModel extends BaseModel {
  id: string;
  name: string;
  midname: string;
  surname: string;
  address: string;
  email: string;
  phoneNumber: string;
}
