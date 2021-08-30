import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VingummierComponent } from './vingummier.component';

describe('VingummierComponent', () => {
  let component: VingummierComponent;
  let fixture: ComponentFixture<VingummierComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VingummierComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VingummierComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
