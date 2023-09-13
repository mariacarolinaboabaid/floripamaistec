import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarroselComponent } from './carrosel.component';

describe('CarroselComponent', () => {
  let component: CarroselComponent;
  let fixture: ComponentFixture<CarroselComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CarroselComponent]
    });
    fixture = TestBed.createComponent(CarroselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
