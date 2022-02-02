import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteHatComponent } from './delete-hat.component';

describe('DeleteHatComponent', () => {
  let component: DeleteHatComponent;
  let fixture: ComponentFixture<DeleteHatComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeleteHatComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeleteHatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
