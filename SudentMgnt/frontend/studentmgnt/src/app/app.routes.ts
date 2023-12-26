import { Routes } from '@angular/router';
import { DashbordComponent } from './components/dashbord/dashbord.component';
import { StudentsComponent } from './components/students/students.component';
import { StudentDetailComponent } from './components/student-detail/student-detail.component';
import { AddStudentComponent } from './components/add-student/add-student.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { CoursesComponent } from './components/courses/courses.component';

export const routes: Routes = [
    { path: '', component: DashbordComponent },
    { path: 'courses', component: CoursesComponent },
    { path: 'students', component: StudentsComponent },
    { path: 'student-detail', component: StudentDetailComponent },
    { path: 'add-student', component: AddStudentComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
]


