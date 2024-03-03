import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchListComponent } from './upload-files.component';

describe('SearchListComponent', () => {
  let component: SearchListComponent;
  let fixture: ComponentFixture<SearchListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SearchListComponent]
    });
    fixture = TestBed.createComponent(SearchListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
