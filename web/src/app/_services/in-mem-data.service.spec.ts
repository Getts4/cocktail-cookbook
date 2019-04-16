import { TestBed } from '@angular/core/testing';

import { InMemDataService } from './in-mem-data.service';

describe('InMemDataService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: InMemDataService = TestBed.get(InMemDataService);
    expect(service).toBeTruthy();
  });
});
