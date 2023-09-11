import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicioComponent } from './exercicio.component';
import { ValidacaoService } from '../services/validacao.service';

describe('ExercicioComponent', () => {
  let component: ExercicioComponent;
  let fixture: ComponentFixture<ExercicioComponent>;
  let validacaoService: ValidacaoService; 

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ExercicioComponent],
      providers: [ValidacaoService]
    });
    fixture = TestBed.createComponent(ExercicioComponent);
    component = fixture.componentInstance;
    validacaoService = TestBed.inject(ValidacaoService);
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  fit(`${ExercicioComponent.prototype.enviarDados1.name} verifica se o método validação foi chamado`,
  () => {
    spyOn(component, 'validacao')
    component.enviarDados1()
    expect(component.validacao).toHaveBeenCalled();
  })

  fit(`${ExercicioComponent.prototype.enviarDados2.name} verifica se o método validação foi chamado`,
  () => {
    spyOn(validacaoService, 'validacao')
    component.enviarDados2()
    expect(validacaoService.validacao).toHaveBeenCalled();
  })
});
