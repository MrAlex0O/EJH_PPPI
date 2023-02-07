import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { LessonTypeModel } from '../_models/lessonTypeModel';
const API_PATH = environment.api_path + '/LessonType';
@Injectable({
  providedIn: 'root'
})
export class LessonTypeService {

  constructor(private _http: HttpClient) { }

  public getAll(): Observable<LessonTypeModel[]> {
    return this._http.get<LessonTypeModel[]>(API_PATH);
  }
}
