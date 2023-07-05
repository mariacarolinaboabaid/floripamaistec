import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaisUmaPaginaComponent } from './mais-uma-pagina.component';

describe('MaisUmaPaginaComponent', () => {
  let component: MaisUmaPaginaComponent;
  let fixture: ComponentFixture<MaisUmaPaginaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MaisUmaPaginaComponent]
    });
    fixture = TestBed.createComponent(MaisUmaPaginaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
