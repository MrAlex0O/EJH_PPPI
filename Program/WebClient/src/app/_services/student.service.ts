import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { StudentModel } from '../_models/studentModel';
const API_PATH = environment.api_path + '/Student';
@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private _http: HttpClient) { }

  public getAll(): Observable<StudentModel[]> {
    return this._http.get<StudentModel[]>(API_PATH);
  }
  public getByGroupId(id: string): Observable<StudentModel[]> {
    return this._http.get<StudentModel[]>(API_PATH + '/byGroupId/' +  id);
  }
  public Update(student: StudentModel): Observable<any> {
    return this._http.put<any>(API_PATH + '/' + student.id, student);
  }
  public Delete(student: StudentModel): Observable<any> {
    return this._http.delete(API_PATH + '/' + student.id);
  }
  public Add(student: StudentModel): Observable<any> {
    return this._http.post(API_PATH, student);
  }
}
