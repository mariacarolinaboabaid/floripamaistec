import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SomaComponent } from './soma.component';

describe('SomaComponent', () => {
  let component: SomaComponent;
  let fixture: ComponentFixture<SomaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SomaComponent]
    });
    fixture = TestBed.createComponent(SomaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  fit(`${SomaComponent.prototype.calculoMedia.name} deve retornar a média de três valores`, ()  => {
    expect(component.calculoMedia(1, 1, 1)).toEqual(1);
    expect(component.calculoMedia(1, 2, 3)).toEqual(2);
    expect(component.calculoMedia(10, 34, 55)).toEqual(33);
  })
});
