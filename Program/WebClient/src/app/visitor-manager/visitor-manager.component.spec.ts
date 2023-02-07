import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VisitorManagerComponent } from './visitor-manager.component';

describe('VisitorManagerComponent', () => {
  let component: VisitorManagerComponent;
  let fixture: ComponentFixture<VisitorManagerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VisitorManagerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VisitorManagerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
