import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { DisciplineModel } from '../_models/disciplineModel';

const API_PATH = environment.api_path + '/Discipline';
@Injectable({
  providedIn: 'root'
})
export class DisciplineService {

  constructor(private _http: HttpClient) { }

  public getAll() :Observable<DisciplineModel[]> {
    return this._http.get<DisciplineModel[]>(API_PATH);
  }
  public Update(discipline: DisciplineModel): Observable<any> {
    return this._http.put(API_PATH + '/' + discipline.id, discipline);
  }
  public Delete(discipline: DisciplineModel): Observable<any> {
    return this._http.delete(API_PATH + '/' + discipline.id);
  }
  public Add(discipline: DisciplineModel): Observable<any> {
    return this._http.post(API_PATH, discipline);
  }
}
