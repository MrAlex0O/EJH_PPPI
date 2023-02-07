import { ReportModel } from "./reportModel";

export interface StudentVisitsReportModel extends ReportModel { 
  DisciplineName: string;
  LessonTypeName: string;
  Present: number;
  Missing: number;
  Liberation: number;
  AnotherSubgroup: number; 
  SeriousReason: number;
  Incalculable: number;

}
