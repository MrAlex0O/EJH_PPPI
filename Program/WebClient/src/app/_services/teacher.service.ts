import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { TeacherModel } from '../_models/teacherModel';
const API_PATH = environment.api_path + '/Teacher';
@Injectable({
  providedIn: 'root'
})
export class TeacherService {

  constructor(private _http: HttpClient) { }

  public getAll(): Observable<TeacherModel[]> {
    return this._http.get<TeacherModel[]>(API_PATH);
  }
  public Update(teacher: TeacherModel): Observable<any> {
    return this._http.put<any>(API_PATH + '/' + teacher.id, teacher);
  }
  public Delete(teacher: TeacherModel): Observable<any> {
    return this._http.delete(API_PATH + '/' + teacher.id);
  }
  public Add(teacher: TeacherModel): Observable<any> {
    return this._http.post(API_PATH, teacher);
  }
}
