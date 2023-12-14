import { Routes } from '@angular/router';
import { DashbordComponent } from './components/dashbord/dashbord.component';
import { StudentsComponent } from './components/students/students.component';
import { StudentDetailComponent } from './components/student-detail/student-detail.component';

export const routes: Routes = [
    { path: '', component: DashbordComponent },
    { path: 'students', component: StudentsComponent },
    { path: 'student-detail', component: StudentDetailComponent },
]


