import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SureBolcherComponent } from './sure-bolcher.component';

describe('SureBolcherComponent', () => {
  let component: SureBolcherComponent;
  let fixture: ComponentFixture<SureBolcherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SureBolcherComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SureBolcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
