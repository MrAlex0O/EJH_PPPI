import { Component, Input, OnInit, TemplateRef, ViewChild, ViewContainerRef } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatSort } from '@angular/material/sort';
import { GenericComboBoxComponent } from '../generic-combo-box/generic-combo-box.component';
import { GenericTableComponent } from '../generic-table/generic-table.component';
import { RenderFunctions } from '../_helpers/renderFunctions';
import { DisciplineModel } from '../_models/disciplineModel';
import { GroupModel } from '../_models/groupModel';
import { BaseReportModel } from '../_models/Reports/baseReportModel';
import { DisciplineVisitsReportModel } from '../_models/Reports/DisciplineVisitsModel';
import { ReportModel } from '../_models/Reports/reportModel';
import { StudentModel } from '../_models/studentModel';
import { DisciplineService } from '../_services/discipline.service';
import { GroupService } from '../_services/group.service';
import { ReportService } from '../_services/report.service';
import { StudentService } from '../_services/student.service';
import { StudentVisitsByDayRequest } from '../_models/Reports/studentVisitsByDayRequest';
import { StudentVisitsByIntervalRequest } from '../_models/Reports/studentVisitsByIntervalRequest';
import { DateToJSONString } from '../_helpers/dateFunctions';

@Component({
  selector: 'report-manager',
  templateUrl: './report-manager.component.html',
  styleUrls: ['./report-manager.component.scss']
})
export class ReportManagerComponent implements OnInit {

  @Input() selectedReport: ReportModel;
  @Input() selectedDiscipline: DisciplineModel;
  @Input() selectedGroup: GroupModel;
  @Input() selectedStudent: StudentModel;
  isGroup: boolean;
  isStudent: boolean;
  isDiscipline: boolean;
  isDate: boolean;
  isDateInterval: boolean;
  reports: ReportModel[] = [
    {
      id: reportTypeEnum.disciplineVisits, name: "Посещаемость дисциплин (за все время)", headers: {
        'fullName': 'ФИО', 'present': 'Присутствовал', 'missing': 'Отсутствовал', 'liberation': 'Освобождение',
        'anotherSubgroup': 'Другая подгруппа', 'seriousReason': 'Уважительная причина', 'incalculable': 'Невычислимо'
      } },
    {
      id: reportTypeEnum.studentVisits, name: "Посещаемость студента (за все время)", headers: {
        'disciplineName': 'Дисциплина',
        'lessonTypeName': 'Тип занятия', 'present': 'Присутствовал', 'missing': 'Отсутствовал', 'liberation': 'Освобождение',
        'anotherSubgroup': 'Другая подгруппа', 'seriousReason': 'Уважительная причина', 'incalculable': 'Невычислимо'
      } },
    {
      id: reportTypeEnum.studentVisitsByDay, name: "Посещаемость студента (за день)", headers: {
        'disciplineName': 'Дисциплина',
        'lessonTypeName': 'Тип занятия', 'present': 'Присутствовал', 'missing': 'Отсутствовал', 'liberation': 'Освобождение',
        'anotherSubgroup': 'Другая подгруппа', 'seriousReason': 'Уважительная причина', 'incalculable': 'Невычислимо'
      } },
    {
      id: reportTypeEnum.studentVisitsByInterval, name: "Посещаемость студента (за интервал)", headers: {
        'disciplineName': 'Дисциплина',
        'lessonTypeName': 'Тип занятия', 'present': 'Присутствовал', 'missing': 'Отсутствовал', 'liberation': 'Освобождение',
        'anotherSubgroup': 'Другая подгруппа', 'seriousReason': 'Уважительная причина', 'incalculable': 'Невычислимо'
      } }
  ];
  disciplines: DisciplineModel[] = [];
  groups: GroupModel[] = [];
  students: StudentModel[] = [];
  @ViewChild(GenericComboBoxComponent) viewChild!: GenericComboBoxComponent;
  @ViewChild(GenericTableComponent) tableViewChild!: GenericTableComponent;
  reportRenderFunction = RenderFunctions.reportRenderFunction;
  disciplineRenderFunction = RenderFunctions.disciplineRenderFunction;
  groupRenderFunction = RenderFunctions.groupRenderFunction;
  studentRenderFunction = RenderFunctions.studentRenderFunction;
  loading: boolean = false;

  date = new FormControl(new Date());
  range = new FormGroup({
    start: new FormControl<Date | null>(new Date()),
    end: new FormControl<Date | null>(new Date()),
  });
  tableData: BaseReportModel[] = [];
  columnHeader = {};

  constructor(private _reportService: ReportService, private _disciplineService: DisciplineService,
    private _groupService: GroupService, private _studentService: StudentService) {
    this.clearFlags();
  }
  clearFlags() {
    this.isDiscipline = false;
    this.isGroup = false;
    this.isStudent = false;
    this.isDate = false;
    this.isDateInterval = false;
  }
  ngOnInit() {
    this._disciplineService.getAll().subscribe(disciplines => this.disciplines.push(...disciplines));
    this._groupService.getAll().subscribe(groups => this.groups.push(...groups));
    this._studentService.getAll().subscribe(students => this.students.push(...students));
  }


  importReport(report: ReportModel) {
    this.selectedReport = report;
    this.columnHeader = report.headers;
    this.clearFlags();
    this.tableData = [];
    this.rerender();
    switch (report.id) {
      case reportTypeEnum.disciplineVisits: {
        this.isDiscipline = true;
        break;
      }
      case reportTypeEnum.studentVisits: {
        this.isStudent = true;
        break;
      }
      case reportTypeEnum.studentVisitsByDay: {
        this.isStudent = true;
        this.isDate = true;
        break;
      }
      case reportTypeEnum.studentVisitsByInterval: {
        this.isDateInterval = true;
        this.isStudent = true;
        break;
      }
    }
  }
  importGroup(group: GroupModel) {
    this.selectedGroup = group;
  }
  importDiscipline(discipline: DisciplineModel) {
    this.selectedDiscipline = discipline;
  }
  importStudent(student: StudentModel) {
    this.selectedStudent = student;
  }

  getReportData() {
    this.tableData.length = 0;
    switch (this.selectedReport.id) {
      case reportTypeEnum.disciplineVisits: {
        this._reportService.getDisciplineVisits(this.selectedDiscipline.id).subscribe(data => {
          this.tableData.push(...data);
          this.rerender();
        });
        break;
      }
      case reportTypeEnum.studentVisits: {
        this._reportService.getStudentVisits(this.selectedStudent.id).subscribe(data => {
          this.tableData.push(...data);
          this.rerender();
        });
        break;
      }
      case reportTypeEnum.studentVisitsByDay: {
        this._reportService.getStudentVisitsByDay({
          studentId: this.selectedStudent.id,
          date: DateToJSONString(<Date>this.date.value) }).subscribe(data => {
          this.tableData.push(...data);
          this.rerender();
        });
        break;
      }
      case reportTypeEnum.studentVisitsByInterval: {
        this._reportService.getStudentVisitsByInterval({
            studentId: this.selectedStudent.id,
          dateStart: DateToJSONString(<Date>this.range.value.start),
          dateEnd: DateToJSONString(<Date>this.range.value.end)
        }).subscribe(data => {
          this.tableData.push(...data);
          this.rerender();
        });
        break;
      }
    }
    
  }

  @ViewChild('outlet', { read: ViewContainerRef }) outletRef: ViewContainerRef;
  @ViewChild('content', { read: TemplateRef }) contentRef: TemplateRef<any>;

  rerender() {
    this.outletRef.clear();
    this.outletRef.createEmbeddedView(this.contentRef);
  }


}


enum reportTypeEnum {
  disciplineVisits = "disciplineVisits",
  studentVisits = 'studentVisits',
  studentVisitsByDay = 'studentVisitByDay',
  studentVisitsByInterval = 'studentVisitByInterval'
}
