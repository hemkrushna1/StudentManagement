using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Business.DTO;
using StudentManagement.Business.Interfaces;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStudentService _studentService;
        private readonly IUserService _userService;
        private readonly ISchoolClassService _schoolClassService;

        public StudentsController(IMapper mapper,
            IStudentService studentService,
            IUserService userService,
            ISchoolClassService schoolClassService)
        {
            _mapper = mapper;
            _studentService = studentService;
            _userService = userService;
            _schoolClassService = schoolClassService;
        }

        // Display list of all students
        public async Task<IActionResult> Index()
        {
            var studentsDto = await _studentService.Get();

            var studentModels = _mapper.Map<IEnumerable<StudentModel>>(studentsDto);

            return View(studentModels);
        }

        // Edit the student's details
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _userService.Get(id);

            if (student == null)
            {
                return NotFound();
            }

            var classes = await _schoolClassService.Get();

            ViewData["Classes"] = new SelectList(classes.ToList(), "Id", "Name");
            return View(student);
        }

        // Handle the edit form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UserModel student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var studentDTO = _mapper.Map<UserDTO>(student);

                    await _userService.Update(studentDTO);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _userService.Exists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateActiveStatus(List<UserUpdateModel> userUpdateModels)
        {
            foreach (var model in userUpdateModels)
            {
                await _userService.Update(model.StudentId, model.Active);
            }

            return RedirectToAction("Index");
        }
    }
}