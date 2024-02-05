import { TestBed } from '@angular/core/testing';

import { CompetitieService } from './competitie.service';

describe('CompetitieService', () => {
  let service: CompetitieService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CompetitieService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
