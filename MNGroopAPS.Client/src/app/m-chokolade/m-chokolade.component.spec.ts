import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MChokoladeComponent } from './m-chokolade.component';

describe('MChokoladeComponent', () => {
  let component: MChokoladeComponent;
  let fixture: ComponentFixture<MChokoladeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MChokoladeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MChokoladeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
