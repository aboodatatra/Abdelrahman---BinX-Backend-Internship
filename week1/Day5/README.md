# Day 5 – Git Branching, Feature Branches & Pull Requests

## Overview

On Day 5, I learned how professional software teams organize their work using Git branches instead of developing everything directly on the main branch.

I practiced creating feature branches, switching between branches, committing changes, pushing branches to GitHub, and understanding how Pull Requests are used to merge completed work into the main branch.

This day helped me understand the workflow that most software development teams follow when collaborating on projects.

---

# Learning Objectives

During this session I learned how to:

- Understand the purpose of Git branches.
- Create and switch between branches.
- Keep the main branch stable.
- Develop features independently.
- Push branches to GitHub.
- Understand how Pull Requests work.
- Merge feature branches back into the main branch.
- Inspect remote repositories.

---

# What I Practiced

## 1. Viewing Remote Repository

I checked the connected GitHub repository by running:

```bash
git remote -v
```

This command displayed both the fetch and push URLs connected to my local project.

---

## 2. Creating a Feature Branch

I created a new feature branch:

```bash
git checkout -b feature/week1-foundations
```

This command:

- Created a new branch.
- Switched directly to it.

---

## 3. Verifying Current Branch

I checked the active branch using:

```bash
git branch
```

The current branch appears with:

```
*
```

which indicates the active working branch.

---

## 4. Checking Repository Status

I monitored repository changes using:

```bash
git status
```

This command showed:

- Modified files
- New files
- Files ready to commit

---

## 5. Staging Files

I added project files using:

```bash
git add .
```

This stages every modified file.

---

## 6. Creating a Commit

I saved my work using:

```bash
git commit -m "Complete Week1 Day5"
```

Each commit represents a snapshot of the project.

---

## 7. Pushing the Branch

I uploaded my feature branch:

```bash
git push origin feature/week1-foundations
```

This created the remote branch on GitHub.

---

## 8. Understanding Pull Requests

A Pull Request is used to request merging a feature branch into the main branch after the work is reviewed.

Normally the workflow is:

Feature Branch
↓

Commit Changes
↓

Push Branch
↓

Open Pull Request
↓

Code Review
↓

Merge into Main

---

# Observation During Practice

After pushing the feature branch, I opened GitHub to create a Pull Request.

GitHub displayed:

```
Showing 0 changed files
```

This happened because the feature branch was created after all Week 1 work had already been merged into the `main` branch.

As a result:

- The feature branch contained exactly the same content as `main`.
- GitHub detected no differences.
- Therefore no Pull Request could be created.

This behavior is expected and indicates that both branches are identical.

---

# Important Lesson Learned

Feature branches should be created **before** starting new work.

Correct workflow:

1. Create Feature Branch
2. Implement Changes
3. Commit
4. Push
5. Open Pull Request
6. Merge into Main

If the branch is created after everything already exists on `main`, GitHub will report **0 changed files** because both branches are identical.

---

# Commands Used

```bash
git remote -v

git checkout -b feature/week1-foundations

git branch

git status

git add .

git commit -m "Complete Week1 Day5"

git push origin feature/week1-foundations
```

---

# Skills Gained

By the end of Day 5 I can:

- Create feature branches.
- Switch between branches.
- Stage and commit changes.
- Push branches to GitHub.
- Understand Pull Request workflow.
- Understand why GitHub may report "0 changed files".
- Follow a professional Git workflow.

---

# Summary

Day 5 introduced the collaborative Git workflow used in real software development teams.

I practiced using feature branches, commits, pushing code to GitHub, and understanding Pull Requests.

I also learned that Pull Requests only appear when there are actual differences between branches. If a feature branch is created after all work already exists on the main branch, GitHub correctly reports **0 changed files**, since there is nothing new to merge.

This knowledge prepares me for working on larger collaborative backend projects using Git and GitHub.