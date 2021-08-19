import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KategoriDeatailsComponent } from './kategori-deatails.component';

describe('KategoriDeatailsComponent', () => {
  let component: KategoriDeatailsComponent;
  let fixture: ComponentFixture<KategoriDeatailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KategoriDeatailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KategoriDeatailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
