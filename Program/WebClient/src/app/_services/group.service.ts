import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { GroupModel } from '../_models/groupModel';
const API_PATH = environment.api_path + '/Group';
@Injectable({
  providedIn: 'root'
})
export class GroupService {

  constructor(private _http: HttpClient) { }

  public getAll(): Observable<GroupModel[]> {
    return this._http.get<GroupModel[]>(API_PATH);
  }
  public Update(group: GroupModel): Observable<any> {
    return this._http.put(API_PATH + '/' + group.id, group);
  }
  public Delete(group: GroupModel): Observable<any> {
    return this._http.delete(API_PATH + '/' + group.id);
  }
  public Add(group: GroupModel): Observable<any> {
    return this._http.post(API_PATH, group);
  }
}
