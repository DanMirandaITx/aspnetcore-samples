CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Blogs" (
    "BlogId" INTEGER NOT NULL CONSTRAINT "PK_Blogs" PRIMARY KEY,
    "Url" TEXT NULL
);

CREATE TABLE "Comments" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Comments" PRIMARY KEY,
    "Message" TEXT NULL
);

CREATE TABLE "Names" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_Names" PRIMARY KEY,
    "Text" TEXT NULL
);

CREATE TABLE "Posts" (
    "PostId" INTEGER NOT NULL CONSTRAINT "PK_Posts" PRIMARY KEY,
    "Title" TEXT NULL,
    "Content" TEXT NULL,
    "BlogId" INTEGER NOT NULL,
    CONSTRAINT "FK_Posts_Blogs_BlogId" FOREIGN KEY ("BlogId") REFERENCES "Blogs" ("BlogId") ON DELETE CASCADE
);

CREATE INDEX "IX_Posts_BlogId" ON "Posts" ("BlogId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190514181357_InitialConfig', '2.2.4-servicing-10062');

