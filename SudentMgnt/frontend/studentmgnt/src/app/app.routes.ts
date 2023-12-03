import { Routes } from '@angular/router';
import { DashbordComponent } from './components/dashbord/dashbord.component';
import { StudentsComponent } from './components/students/students.component';

export const routes: Routes = [
    { path: '', component: DashbordComponent },
    { path: 'students', component: StudentsComponent },
]


