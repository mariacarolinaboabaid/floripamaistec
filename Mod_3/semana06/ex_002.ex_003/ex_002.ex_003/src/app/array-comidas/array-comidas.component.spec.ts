import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArrayComidasComponent } from './array-comidas.component';

describe('ArrayComidasComponent', () => {
  let component: ArrayComidasComponent;
  let fixture: ComponentFixture<ArrayComidasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ArrayComidasComponent]
    });
    fixture = TestBed.createComponent(ArrayComidasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  fit(`${ArrayComidasComponent.prototype.addStringInicio.name} deve adicionar o parâmetro no início da array`, 
  () => {
    expect(component.addStringInicio('ovo')).toBe('ovo');
    expect(component.addStringInicio('pizza')).toEqual('pizza');
  });

  fit(`${ArrayComidasComponent.prototype.arrayTamanhoMaior.name} deve retornar o tamanho da array maior do que antes`, 
  () => {
    let tamanhoInicial = component.comidas.length
    expect(component.arrayTamanhoMaior('pipoca')).toBeGreaterThan(tamanhoInicial);
  });

  fit(`${ArrayComidasComponent.prototype.arrayTamanhoMenor.name} deve retornar o tamanho da array menor do que antes`, 
  () => {
    let tamanhoInicial = component.comidas.length
    expect(component.arrayTamanhoMenor('brigadeiro')).toBeLessThan(tamanhoInicial);
    expect(component.arrayTamanhoMenor('torta de morango')).toBeLessThan(tamanhoInicial);

  })
});
