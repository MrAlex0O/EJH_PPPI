import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisciplineManagerComponent } from './discipline-manager.component';

describe('DisciplineManagerComponent', () => {
  let component: DisciplineManagerComponent;
  let fixture: ComponentFixture<DisciplineManagerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DisciplineManagerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisciplineManagerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
