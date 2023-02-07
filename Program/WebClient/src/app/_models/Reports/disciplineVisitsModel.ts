import { ReportModel } from "./reportModel";

export interface DisciplineVisitsReportModel extends ReportModel {
  FullName: string;
  Present: number;
  Missing: number;
  Liberation: number;
  AnotherSubgroup: number;
  SeriousReason: number;
  Incalculable: number;
}
