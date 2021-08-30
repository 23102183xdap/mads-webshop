import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HChokoladeComponent } from './h-chokolade.component';

describe('HChokoladeComponent', () => {
  let component: HChokoladeComponent;
  let fixture: ComponentFixture<HChokoladeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HChokoladeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HChokoladeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
