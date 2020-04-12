namespace Portfolio.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Portfolio.Data;
    using Portfolio.Data.Models;

    [Area("Administration")]
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProjectsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: Administration/Projects
        public async Task<IActionResult> Index()
        {
            return this.View(await this.context.Projects.ToListAsync());
        }

        // GET: Administration/Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var project = await this.context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return this.NotFound();
            }

            return this.View(project);
        }

        // GET: Administration/Projects/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImagePath,Url,GitHubUrl")] Project project)
        {
            if (this.ModelState.IsValid)
            {
                this.context.Add(project);
                await this.context.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(project);
        }

        // GET: Administration/Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var project = await this.context.Projects.FindAsync(id);
            if (project == null)
            {
                return this.NotFound();
            }

            return this.View(project);
        }

        // POST: Administration/Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImagePath,Url,GitHubUrl")] Project project)
        {
            if (id != project.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.context.Update(project);
                    await this.context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.ProjectExists(project.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(project);
        }

        // GET: Administration/Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var project = await this.context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return this.NotFound();
            }

            return this.View(project);
        }

        // POST: Administration/Projects/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await this.context.Projects.FindAsync(id);
            this.context.Projects.Remove(project);
            await this.context.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool ProjectExists(int id)
        {
            return this.context.Projects.Any(e => e.Id == id);
        }
    }
}
