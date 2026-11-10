<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('form-login');
});

route::get('form-login',[AuthController::class],'masuk');
route::post('form-login',[AuthController::class]);
