import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AngularMaterialModule } from '../modules/angularmaterial/angularmaterial.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { EmployeesComponent } from './employees/employees.component';


@NgModule({
  declarations: [EmployeesComponent],
  imports: [
    CommonModule,
    AngularMaterialModule,
    FlexLayoutModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class ViewsModule { }
