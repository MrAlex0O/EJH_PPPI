import { DisciplineModel } from "../_models/disciplineModel";
import { GroupModel } from "../_models/groupModel";
import { LessonModel } from "../_models/lessonModel";
import { LessonTypeModel } from "../_models/lessonTypeModel";
import { ReportModel } from "../_models/Reports/reportModel";
import { StudentModel } from "../_models/studentModel";
import { TeacherModel } from "../_models/teacherModel";

export class RenderFunctions {
  public static studentRenderFunction = (item: StudentModel) => { return `${item.surname} ${item.name} ${item.midname} ${item.groupName}`; }
  public static groupRenderFunction = (item: GroupModel) => { return `${item.name}`; }
  public static teacherRenderFunction = (item: TeacherModel) => { return `${item.surname} ${item.name} ${item.midname}`; }
  public static disciplineRenderFunction = (item: DisciplineModel) => { return `${item.name} ${item.groupName}`; }
  public static lessonRenderFunction = (item: LessonModel) => { return `${item.disciplineName} ${item.groupName} ${item.date} ${item.lessonType}`; }
  public static lessonTypeRenderFunction = (item: LessonTypeModel) => { return `${item.name}`; }
  public static reportRenderFunction = (item: ReportModel) => { return `${item.name}`; }
}
