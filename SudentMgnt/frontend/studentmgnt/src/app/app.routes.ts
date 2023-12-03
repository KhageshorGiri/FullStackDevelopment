import { Routes } from '@angular/router';
import { DashbordComponent } from './components/dashbord/dashbord.component';
import { ProductComponent } from './components/product/product.component';

export const routes: Routes = [
    { path: '', component: DashbordComponent },
    { path: 'products', component: ProductComponent },
]


