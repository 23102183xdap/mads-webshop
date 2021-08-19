import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KvugComponent } from './kvug.component';

describe('KvugComponent', () => {
  let component: KvugComponent;
  let fixture: ComponentFixture<KvugComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KvugComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KvugComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
