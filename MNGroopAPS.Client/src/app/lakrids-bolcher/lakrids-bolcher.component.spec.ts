import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LakridsBolcherComponent } from './lakrids-bolcher.component';

describe('LakridsBolcherComponent', () => {
  let component: LakridsBolcherComponent;
  let fixture: ComponentFixture<LakridsBolcherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LakridsBolcherComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LakridsBolcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
