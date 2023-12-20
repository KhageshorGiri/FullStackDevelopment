import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormControl, FormGroup, Validators } from '@angular/forms';
import { StudentService } from '../../core/services/student.service';

@Component({
  selector: 'app-add-student',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './add-student.component.html',
  styleUrl: './add-student.component.scss'
})

export class AddStudentComponent implements OnInit{
  addStudentForm!: FormGroup;
  studentService!: StudentService;

  constructor(studentService: StudentService){
    this.studentService = studentService;
  }

  //********************************************************
  // Private Functions 
  //********************************************************
  ngOnInit(){
    this.addStudentForm = new FormGroup({
      fullName: new FormControl('', [Validators.required]),
      birthDate: new FormControl('', [Validators.required]),
      faculty: new FormControl('', [Validators.required])
    });
  }

  //********************************************************
  // Public Functions 
  //********************************************************
  onFormSubmit(event: Event){
    event.preventDefault();
    
    this.studentService.addStudent(this.addStudentForm.value);
  }
}
