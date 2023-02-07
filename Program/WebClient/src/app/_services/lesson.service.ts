import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { LessonModel } from '../_models/lessonModel';
const API_PATH = environment.api_path + '/Lesson';
@Injectable({
  providedIn: 'root'
})
export class LessonService {

  constructor(private _http: HttpClient) { }

  public getAll(): Observable<LessonModel[]> {
    return this._http.get<LessonModel[]>(API_PATH);
  }
  public Update(lesson: LessonModel): Observable<any> {
    return this._http.put(API_PATH + '/' + lesson.id, lesson);
  }
  public Delete(lesson: LessonModel): Observable<any> {
    return this._http.delete(API_PATH + '/' + lesson.id);
  }
  public Add(lesson: LessonModel): Observable<any> {
    return this._http.post(API_PATH, lesson);
  }
}
