import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersoaneComponent } from './persoana.component';

describe('PersoanaComponent', () => {
  let component: PersoaneComponent;
  let fixture: ComponentFixture<PersoaneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PersoaneComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PersoaneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
