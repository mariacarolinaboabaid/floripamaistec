import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArrayComponent } from './array.component';

describe('ArrayComponent', () => {
  let component: ArrayComponent;
  let fixture: ComponentFixture<ArrayComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ArrayComponent]
    });
    fixture = TestBed.createComponent(ArrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  fit('Deve retornar se lasanha está dentro da array comidas',
  () => {
    expect(component.comidas).toContain('lasanha');
  });

  fit(`${ArrayComponent.prototype.retornaIndex.name} deve retornar um erro caso a string procurada não esteja na array`,
  () => {
    expect(() => {component.retornaIndex('banana')}).toThrow();
  });


});
