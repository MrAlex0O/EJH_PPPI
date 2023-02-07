import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { DisciplineVisitsReportModel } from '../_models/Reports/DisciplineVisitsModel';
import { StudentVisitsByDayRequest } from '../_models/Reports/studentVisitsByDayRequest';
import { StudentVisitsByIntervalRequest } from '../_models/Reports/studentVisitsByIntervalRequest';
import { StudentVisitsReportModel } from '../_models/Reports/studentVisitsModel';

const API_PATH = environment.api_path + '/Report';
@Injectable({
  providedIn: 'root'
})
export class ReportService {

  constructor(private _http: HttpClient) { }

  public getDisciplineVisits(id: string): Observable<DisciplineVisitsReportModel[]> {
    return this._http.get<DisciplineVisitsReportModel[]>(API_PATH + '/disciplineVisits/' + id);
  }
  public getStudentVisits(id: string): Observable<StudentVisitsReportModel[]> {
    return this._http.get<StudentVisitsReportModel[]>(API_PATH + '/studentVisits/' + id);
  }
  public getStudentVisitsByDay(model: StudentVisitsByDayRequest): Observable<StudentVisitsReportModel[]> {
    return this._http.post<StudentVisitsReportModel[]>(API_PATH + '/studentVisitsByDay', model);
  }
  public getStudentVisitsByInterval(model: StudentVisitsByIntervalRequest): Observable<StudentVisitsReportModel[]> {
    return this._http.post<StudentVisitsReportModel[]>(API_PATH + '/studentVisitsByInterval', model);
  }
}
