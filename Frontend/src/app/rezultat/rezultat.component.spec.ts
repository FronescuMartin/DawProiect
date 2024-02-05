import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RezultatComponent } from './rezultat.component';

describe('RezultatComponent', () => {
  let component: RezultatComponent;
  let fixture: ComponentFixture<RezultatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RezultatComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RezultatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
