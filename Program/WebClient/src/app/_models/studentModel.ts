import { BaseModel } from "./BaseModel";

export interface StudentModel extends BaseModel {
  id: string;
  name: string;
  midname: string;
  surname: string;
  address: string;
  email: string;
  phoneNumber: string;
  groupId: string;
  groupName: string;
}

