import { Component, OnInit, ViewChildren } from '@angular/core';
import { RenderFunctions } from '../_helpers/renderFunctions';
import { LessonModel } from '../_models/lessonModel';
import { StatusOnLesson } from '../_models/statusOnLesson';
import { StudentModel } from '../_models/studentModel';
import { StudentVisitModel } from '../_models/studentVisitModel';
import { LessonService } from '../_services/lesson.service';
import { StudentService } from '../_services/student.service';
import { VisitorService } from '../_services/visitor.service';

@Component({
  selector: 'app-visitor-manager',
  templateUrl: './visitor-manager.component.html',
  styleUrls: ['./visitor-manager.component.css']
})
export class VisitorManagerComponent implements OnInit {
  loading: boolean = false;
  selectedLesson: LessonModel;
  statuses: StatusOnLesson[] = [];

  students: StudentModel[] = [];
  selectedStatuses: StatusOnLesson[] = [];
  lessons: LessonModel[] = [];
  renderFunction = RenderFunctions.lessonRenderFunction;
  constructor(private _studentService: StudentService, private _visitorService: VisitorService, private _lessonService: LessonService) { }

  ngOnInit(): void {
    this.loading = true;
    this.statuses.length = 0;
    this._visitorService.getStatusesOnLesson().subscribe(statuses => { this.statuses.push(...statuses); this.loading = false });
    this._lessonService.getAll().subscribe(lessons => { this.lessons.push(...lessons); this.loading = false });

  }

  importLesson(lesson: LessonModel) {
    this.selectedLesson = lesson;
    this.loading = true;
    this.students.length = 0;
    this._studentService.getByGroupId(this.selectedLesson.groupId).subscribe(students => {
      this.students.push(...students);
      this.selectedStatuses.length = 0;
      for (let i = 0; i < this.students.length; i++) {
        this.selectedStatuses.push({
            id: "",
            name: ""
        });
      }

      this.loading = false;
    });
    
    this.show();
  }

  show() {

    this.loading = true;
    this._visitorService.getVisitsByLessonId(this.selectedLesson.id).subscribe(visits => {
      for (let i = 0; i < visits.studentsIds.length; i++) {


        let studentIndex: number = this.students.findIndex(s => s.id == visits.studentsIds[i]);
        this.selectedStatuses[studentIndex] = <StatusOnLesson>this.statuses.find(s => s.id == visits.studentStatusesIds[i]);
      }

    });
  }

  save(i: number) {
    let visit: StudentVisitModel = {
      lessonId: this.selectedLesson.id,
      studentId: this.students[i].id,
      statusOnLessonId: this.selectedStatuses[i].id
    };

    this._visitorService.postVisit(visit).subscribe();

  }
  selectStatus(i: number, selected: StatusOnLesson) {
    this.selectedStatuses[i] = selected;
  }
}
