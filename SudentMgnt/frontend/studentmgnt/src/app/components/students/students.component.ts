import {AfterViewInit, Component, Injectable, OnInit, ViewChild} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort, MatSortModule} from '@angular/material/sort';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatIconModule} from '@angular/material/icon';
import { Student } from '../../core/interfaces/student.interface';
import {StudentService} from '../../core/services/student.service';
import { RouterLink, RouterLinkActive } from '@angular/router';


@Component({
  selector: 'app-students',
  standalone: true,
  imports: [CommonModule, MatFormFieldModule, MatInputModule, RouterLink, RouterLinkActive,
    MatTableModule, MatSortModule, MatPaginatorModule, MatIconModule],
  templateUrl: './students.component.html',
  styleUrl: './students.component.scss'
})


export class StudentsComponent implements OnInit{

  studentTableDisplayColumns: string[] = ['id', 'name', 'birthDate', 'faculty', 'action']
  studentTableDataSource!: MatTableDataSource<Student>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  studentsDetails: Student[] = [];
  constructor(private studentService: StudentService) {
   
    this.studentsDetails = studentService.getAllStudents();
    // Assign the data to the data source for the table to render
    this.studentTableDataSource = new MatTableDataSource(this.studentsDetails);
  }
  
  //********************************************************
  // Private Functions 
  //********************************************************
  ngOnInit(): void {
    //.. 
  }

  ngAfterViewInit() {
    this.studentTableDataSource.paginator = this.paginator;
    this.studentTableDataSource.sort = this.sort;
  }


  //********************************************************
  // Public Functions 
  //********************************************************
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.studentTableDataSource.filter = filterValue.trim().toLowerCase();

    if (this.studentTableDataSource.paginator) {
      this.studentTableDataSource.paginator.firstPage();
    }
  }

}
