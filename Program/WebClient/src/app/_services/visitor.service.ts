import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { LessonVisitModel } from '../_models/lessonVisit';
import { StatusOnLesson } from '../_models/statusOnLesson';
import { StudentVisitModel } from '../_models/studentVisitModel';
const API_PATH = environment.api_path;
@Injectable({
  providedIn: 'root'
})
export class VisitorService {

  constructor(private _http: HttpClient) { }
  public getStatusesOnLesson(): Observable<StatusOnLesson[]> {
    return this._http.get<StatusOnLesson[]>(API_PATH + "/StatusOnLesson");
  }
  public postVisit(studentVisit: StudentVisitModel) {
    return this._http.post(API_PATH + "/LessonVisitor", studentVisit);
  }
  public getVisitsByLessonId(id: string): Observable<LessonVisitModel> {

    return this._http.get<LessonVisitModel>(API_PATH + "/LessonVisitor/byLessonId/" + id);
  }
}
