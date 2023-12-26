
import { Injectable } from "@angular/core";
import allCourses from "../constants/course.data";

@Injectable({
    providedIn: 'root', // This means the service is provided in the root injector
  })
  export class CourseService{

    // method to get all student
    getAllCourses(){
        return allCourses;
    }

    // method to get course by id
    getCourseById(Id:number){
        // to do.
    }

    // method to add new course
    addNewCourse(newCourse: any){
        // to do..
    }

    // method to update course
    updateCourse(existingCourse:any){
        // to do..
    }

    // method to delete course
    deleteCourse(Id:string){
        // to do..
    }
  }