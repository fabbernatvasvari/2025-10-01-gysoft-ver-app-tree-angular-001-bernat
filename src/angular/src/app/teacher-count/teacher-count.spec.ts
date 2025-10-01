import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TeacherCount } from './teacher-count';

describe('TeacherCount', () => {
  let component: TeacherCount;
  let fixture: ComponentFixture<TeacherCount>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TeacherCount]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TeacherCount);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
