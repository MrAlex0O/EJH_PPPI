import { BaseModel } from "./BaseModel";

export interface LessonVisitModel extends BaseModel {

  disciplineId: string,
  disciplineName: string,
  date: Date| null,
  lessonId: string,
  lessonTypeId: string,
  lessonTypeName: string,
  studentsIds: string[],
  lessonsVisitorsIds: string[],
  studentFullName: string[],
  studentStatusesIds: string[],
  studentStatusesNames: string[]
}
