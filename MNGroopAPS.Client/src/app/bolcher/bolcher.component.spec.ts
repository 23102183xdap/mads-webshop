import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BolcherComponent } from './bolcher.component';

describe('BolcherComponent', () => {
  let component: BolcherComponent;
  let fixture: ComponentFixture<BolcherComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BolcherComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BolcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
