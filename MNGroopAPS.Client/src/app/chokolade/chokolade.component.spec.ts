import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChokoladeComponent } from './chokolade.component';

describe('ChokoladeComponent', () => {
  let component: ChokoladeComponent;
  let fixture: ComponentFixture<ChokoladeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChokoladeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChokoladeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
