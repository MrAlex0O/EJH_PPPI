import { BaseModel } from "./BaseModel";

export interface LessonModel extends BaseModel {
  
  id: string;
  disciplineId: string;
  disciplineName: string;
  groupId: string;
  groupName: string;
  lectorId: string;
  lectorFullName: string;
  assistantsIds: string[];
  assistantsFullNames: string[];
  lessonTypeId: string;
  lessonType: string;
  date: string;
  sequenceNumber: number
}
