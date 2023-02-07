import { BaseModel } from "../BaseModel";

export interface ReportModel extends BaseModel {
  name: string;
  headers: object;
}
