import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BlandetBolcherComponent } from './blandet-bolcher.component';

describe('BlandetBolcherComponent', () => {
  let component: BlandetBolcherComponent;
  let fixture: ComponentFixture<BlandetBolcherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BlandetBolcherComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BlandetBolcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
