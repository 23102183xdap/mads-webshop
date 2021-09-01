import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SVingummierComponent } from './s-vingummier.component';

describe('SVingummierComponent', () => {
  let component: SVingummierComponent;
  let fixture: ComponentFixture<SVingummierComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SVingummierComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SVingummierComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
