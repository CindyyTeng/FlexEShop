using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Flex_TEST.Models;
using Flex_TEST.Models.Exts;
using System.Diagnostics;
using Flex_TEST.Interface;
using Flex_TEST.Infra.EFRepository;
using Flex_TEST.Services;
using Flex_TEST.Models.Dto;
using Flex_TEST.Models.ViewModels;
using Flex_TEST.Infra;

namespace Flex_TEST.Controllers
{
    public class ActivitiesController : Controller
    {

        private readonly AppDbContext _context;

        //建構函數
        //控制器（Controller）的建構函數（Constructor），使用了 Dependency Injection（DI）來注入 AppDbContext 服務。
        public ActivitiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Activities
        public async Task<IActionResult> Index()
        {
            IActivityRepository repo = new ActivityRepository(_context);
            ActivityServices service = new ActivityServices(repo, _context);

            var indexInfo = await service.GetAllAsync();
            var indexVM = indexInfo.Select(a => a.ToIndexVM());
            //var indexInfo = await _context.Activities.Include(a => a.fk_ActivityCategory).Include(a=>a.fk_ActivityStatus).Include(a=>a.fk_Speaker).ToListAsync();
            //var indexVM = indexInfo.Select(a=>a.ToIndexDto().ToIndexVM());

            //Console.WriteLine(indexVM.GetType().FullName); // 輸出型別名稱
            //Debug.WriteLine(indexVM.GetType().FullName);

            //_context.Activities.Select(x => x.fk_ActivityCategory.ActivityCategoryName);
            return View(indexVM);



        }

        // GET: Activities/Details/5
       
        public async Task<IActionResult> Details (int? id)
        {
            if(id == null || _context.Activities == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities
                                    .Include(a => a.fk_ActivityCategory)
                                    .Include(a => a.fk_ActivityStatus)
                                    .Include(a => a.fk_Speaker)
                                    .FirstOrDefaultAsync(m =>m.ActivityId == id);

            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }


        // GET: Activities/Create
        //public IActionResult Create()
        //{
        //    ViewData["fk_ActivityCategoryId"] = new SelectList(_context.ActivityCategories, "ActivityCategoryId", "ActivityCategoryName");
        //    ViewData["fk_ActivityStatusId"] = new SelectList(_context.ActivityStatuses, "ActivityStatusId", "ActivityStatusId");
        //    ViewData["fk_SpeakerId"] = new SelectList(_context.Speakers, "SpeakerId", "SpeakerName");
        //    return View();
        //}

        public IActionResult Create()
        {
            ViewData["fk_ActivityCategoryId"] = new SelectList(_context.ActivityCategories, "ActivityCategoryId", "ActivityCategoryName");
            ViewData["fk_SpeakerId"] = new SelectList(_context.Speakers, "SpeakerId", "SpeakerName");
            ViewData["fk_ActivityStatusId"] = new SelectList(_context.ActivityStatuses, "ActivityStatusId", "ActivityStatusDescription");
            return View();
        }

        // POST: Activities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.

        //public async Task<IActionResult> Create([Bind("ActivityId,ActivityName,fk_ActivityCategoryId,ActivityDate,fk_SpeakerId,ActivityPlace,ActivityImage,ActivityBookStartTime,ActivityBookEndTime,ActivityAge,ActivitySalePrice,ActivityOriginalPrice,ActivityDescription,fk_ActivityStatusId")] Activities activities)


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Activities activities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activities);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["fk_ActivityCategoryId"] = new SelectList(_context.ActivityCategories, "ActivityCategoryId", "ActivityCategoryName", activities.fk_ActivityCategoryId);
            ViewData["fk_SpeakerId"] = new SelectList(_context.Speakers, "SpeakerId", "SpeakerName", activities.fk_SpeakerId);
            ViewData["fk_ActivityStatusId"] = new SelectList(_context.ActivityStatuses, "ActivityStatusId", "ActivityStatusDescription", activities.fk_ActivityStatusId);

            return View(activities);
        }






        // GET: Activities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            IActivityRepository repo = new ActivityRepository(_context);
            ActivityServices service = new ActivityServices(repo, _context);

            if (id == null)
            {
                return NotFound();
            }

            var activity = await service.GetOneAsync(id);
            if (activity == null)
            {
                return NotFound();
            }
            var activityVm = activity.ToEditVM();

            ViewData["fk_ActivityCategoryId"] = new SelectList(_context.ActivityCategories, "ActivityCategoryId", "ActivityCategoryName", activityVm.fk_ActivityCategoryId);

            ViewData["fk_SpeakerId"] = new SelectList(_context.Speakers, "SpeakerId", "SpeakerName", activityVm.fk_ActivityCategoryId);
            return View(activityVm);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ActivityEditVM vm)
        {
            // 假設 vm.ActivityId 為 ActivityCategoryId 的值
            ViewData["fk_ActivityCategoryId"] = new SelectList(_context.ActivityCategories, "ActivityCategoryId", "ActivityCategoryName", vm.fk_ActivityCategoryId);


            ViewData["fk_SpeakerId"] = new SelectList(_context.Speakers, "SpeakerId", "SpeakerName", vm.fk_ActivityCategoryId);

            IActivityRepository repo = new ActivityRepository(_context);
            ActivityServices service = new ActivityServices(repo, _context);

            if (id != vm.ActivityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ActivityEditDto dto = vm.ToEditDto();
                Result result = await service.EditAsync(dto);

                if (result.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(vm);
                }
            }
            return View(vm);

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        service.Update(vm);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!ActivitiesExists(activities.ActivityId))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
          
            //return View(activities);
        }

        // GET: Activities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Activities == null)
            {
                return NotFound();
            }

            var activities = await _context.Activities
                .Include(a => a.fk_ActivityCategory)
                .Include(a => a.fk_ActivityStatus)
                .Include(a => a.fk_Speaker)
                .FirstOrDefaultAsync(m => m.ActivityId == id);
            if (activities == null)
            {
                return NotFound();
            }

            return View(activities);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Activities == null)
            {
                return Problem("Entity set 'AppDbContext.Activities'  is null.");
            }
            var activities = await _context.Activities.FindAsync(id);
            if (activities != null)
            {
                _context.Activities.Remove(activities);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivitiesExists(int id)
        {
          return (_context.Activities?.Any(e => e.ActivityId == id)).GetValueOrDefault();
        }
    }
}
